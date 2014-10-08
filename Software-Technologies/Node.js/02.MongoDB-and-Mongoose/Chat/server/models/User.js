'use strict';

var mongoose = require('mongoose');
var uniqueValidator = require('mongoose-unique-validator');

var Schema = mongoose.Schema;

var userSchema = new Schema({
    user: {
        type: String,
        required: true,
        unique: true
    },
    pass: {
        type: String,
        required: true
    }
});

// userSchema.plugin(uniqueValidator, {message: 'Error, expected {PATH} to be unique.'});
var User = mongoose.model('User', userSchema);

module.exports = User;