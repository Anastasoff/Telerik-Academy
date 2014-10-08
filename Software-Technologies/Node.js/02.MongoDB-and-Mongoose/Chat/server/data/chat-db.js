'use strict';

var mongoose = require('mongoose');

var User = mongoose.model('User'),
    Message = mongoose.model('Message');

function registerUser(user) {
    var newUser = new User({
        user: user.user,
        pass: user.pass
    });

    return newUser.save(function (error, result) {
        if (error) {
            console.error(error);
            return error;
        }

        return result;
    });
}

function sendMessage(message) {
    User.findOne({user: message.from}, function (error, result) {
        if (error) {
            console.error(error);
            return error;
        }

        var from = result;

        User.findOne({user: message.to}, function (error, result) {
            if (error) {
                console.error(error);
                return error;
            }

            var to = result;

            var newMessage = new Message({
                from: from._id,
                to: to._id,
                text: message.text
            });

            newMessage.save(function (error, result) {
                if (error) {
                    console.error(error);
                    return error;
                }

                return result;
            });
        });
    });
}

function getMessages(users, callback) {
    var query = User.findOne({user: users.with}, function (error, result) {
        if (error) {
            console.error(error);
            return error;
        }

        var fromId = result._id;

        User.findOne({user: users.and}, function (error, result) {
            if (error) {
                console.error(error);
                return error;
            }

            var toId = result._id;

//            Message
//                .find({from: from._id, to: to._id})
//                .exec(callback);

            Message
                .find()
                .where('from').in([fromId, toId])
                .where('to').in([fromId, toId])
                .populate('from to')
                .exec(callback);
        });
    });

    return query;
}

module.exports = {
    registerUser: registerUser,
    sendMessage: sendMessage,
    getMessages: getMessages
};