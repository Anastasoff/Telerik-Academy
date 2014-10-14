var auth = require('./auth');
controllers = require('../controllers');

module.exports = function (app) {
    app.get('/', function (req, res) {
        res.render('index');
    });

    // User
    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);
    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login, controllers.users.postLogin);
    app.get('/logout', auth.logout, controllers.users.logout);

    app.get('/profile', auth.isAuthenticated, controllers.users.getProfile);
    app.post('/profile', auth.isAuthenticated, controllers.users.postProfile);

    // Event
    app.get('/create', auth.isAuthenticated, controllers.events.getEvent);
    app.post('/create', auth.isAuthenticated, controllers.events.postCreate);

    app.get('*', function (req, res) {
        res.redirect('/');
    });
};