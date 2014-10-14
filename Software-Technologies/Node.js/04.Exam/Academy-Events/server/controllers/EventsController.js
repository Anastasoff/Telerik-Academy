var mongoose = require('mongoose'),
    events = require('../data/events'),
    categories = require('../data/resources/categories'),
    initiatives = require('../data/resources/initiatives'),
    seasons = require('../data/resources/seasons');

var CONTROLLER_NAME = 'events';

module.exports = {
    getEvent: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/create', {
            categories: categories.getAllCategories(),
            initiatives: initiatives.getAllInitiatives(),
            season: seasons.getAllSeasons()
        });
    },
    postCreate: function (req, res, next) {
        var newEventData = req.body;

        if (!newEventData.title) {
            req.session.errorMessage = 'Event title is mandatory!';
            res.redirect('/create');
        } else if (!newEventData.description) {
            req.session.errorMessage = 'Event description is mandatory!';
            res.redirect('/create');
        } else if (!newEventData.category) {
            req.session.errorMessage = 'Event category is mandatory!';
            res.redirect('/create');
        }
        else {
            var eventToSave = {};

            eventToSave.title = newEventData.title;
            eventToSave.description = newEventData.description;
            eventToSave.location = {
                latitude: newEventData.latitude,
                longitude: newEventData.longitude
            };
            eventToSave.eventDate = newEventData.eventDate;
            eventToSave.category = newEventData.category;
            eventToSave.eventType = {
                initiative: newEventData.initiative,
                season: newEventData.season
            };
            eventToSave.creator = req.user._id;

            events.create(eventToSave, function (err, user) {
                if (err) {
                    req.session.errorMessage = 'Create event error!';
                    res.redirect('/create');
                    return;
                }

                res.redirect('/');
            });
        }
    }
};