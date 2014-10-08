'use strict';

var mongoose = require('mongoose');
var User = require('../models/Message');
var Message = require('../models/User');

module.exports = function (connectionString) {
    mongoose.connect(connectionString);
    var db = mongoose.connection;

    db.once('open', function (error) {
        if (error) {
            console.log('Database could not be opened: ' + error);
            return;
        }

        console.log('Database is up and running...');
    });

    db.on('error', function (error) {
        console.log('Connection error: ' + error);
    });
};