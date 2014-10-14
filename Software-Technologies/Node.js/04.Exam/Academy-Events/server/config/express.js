var express = require('express'),
    bodyParser = require('body-parser'),
    cookieParser = require('cookie-parser'),
    session = require('express-session'),
    passport = require('passport'),
    busboy = require('connect-busboy'),
    morgan = require('morgan'),
    favicon = require('serve-favicon');

module.exports = function (app, config) {
    app.set('view engine', 'jade');
    app.set('views', config.rootPath + '/server/views');
    app.use(favicon(config.rootPath + '/public/img/favicon.ico'));
    app.use(express.static(config.rootPath + '/public'));
    app.use(busboy({ immediate: false }));
    app.use(bodyParser.json());
    app.use(bodyParser.urlencoded({extended: true}));
    app.use(cookieParser());
    app.use(session({
        resave: true,
        saveUninitialized: true,
        secret: 'top secret'
    }));
    app.use(passport.initialize());
    app.use(passport.session());

    app.use(function (req, res, next) {
        if (req.session.errorMessage) {
            var msg = req.session.errorMessage;
            req.session.errorMessage = undefined;
            app.locals.errorMessage = msg;
        }
        else {
            app.locals.errorMessage = undefined;
        }

        next();
    });
    app.use(function (req, res, next) {

        app.locals.currentUser = req.user;


        next();
    });

    app.use(morgan('dev'));
};