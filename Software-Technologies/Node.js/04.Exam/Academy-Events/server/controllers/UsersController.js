var encryption = require('../utilities/encryption'),
    users = require('../data/users'),
    CONTROLLER_NAME = 'users';

module.exports = {
    getRegister: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/register');
    },
    postRegister: function (req, res, next) {
        var newUserData = req.body;
        if (newUserData.password != newUserData.confirmPassword) {
            req.session.errorMessage = 'Passwords do not match!';
            res.redirect('/register');
        } else if (newUserData.username.length < 6 || newUserData.username.length >= 20) {
            req.session.errorMessage = 'The Username should be between 6 and 20 characters long!';
            res.redirect('/register');
        } else if (newUserData.password.length < 6) {
            req.session.errorMessage = 'Password must be at least 6 characters!';
            res.redirect('/register');
        } else {
            var userToSave = {};
            userToSave.username = newUserData.username;
            userToSave.salt = encryption.generateSalt();
            userToSave.hashPass = encryption.generateHashedPassword(userToSave.salt, newUserData.password);
            userToSave.firstName = newUserData.firstName;
            userToSave.lastName = newUserData.lastName;
            userToSave.email = newUserData.email;

            users.create(userToSave, function (err, user) {
                if (err) {
                    req.session.errorMessage = err;
                    res.redirect('/register');
                    return;
                }

                req.logIn(user, function (err) {
                    if (err) {
                        res.redirect(CONTROLLER_NAME + '/error');
                        return;
                    }

                    delete  user.salt;
                    delete user.hashPass;
                    res.redirect('/');
                });
            });
        }
    },
    getLogin: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/login-user');
    },
    postLogin: function (req, res, next) {
        if (req.user) {
            res.redirect('/');
        } else {
            res.redirect('/login');
        }
    },
    logout: function (req, res, next) {
        res.redirect('/');
    },
    getProfile: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/profile');
    },
    postProfile: function (req, res, next) {
        var updatedUserData = req.body;

        var userToUpdate = {};
        userToUpdate.links = [];

        userToUpdate.phoneNumber = updatedUserData.phoneNumber;
        userToUpdate.links.push(updatedUserData.facebook);
        userToUpdate.links.push(updatedUserData.googlePlus);
        userToUpdate.links.push(updatedUserData.linkedIn);
        userToUpdate.links.push(updatedUserData.twitter);

        users.update({_id: req.user._id}, userToUpdate, function (err, user) {
            if (err) {
                req.session.errorMessage = 'User update error!';
                res.redirect('/profile');
                return;
            }

            res.redirect('/');
        });
    }
};