var mongoose = require('mongoose');

module.exports.init = function () {
    var eventSchema = mongoose.Schema({
        title: {type: String, require: '{PATH} is required'},
        description: {type: String, require: '{PATH} is required'},
        location: {
            latitude: {type: Number},
            longitude: {type: Number}
        },
        eventDate: {type: Date},
        category: {type: String, require: '{PATH} is required'},
        eventType: {
            initiative: {type: String},
            season: {type: String}
        },
        creator: {type: mongoose.Schema.Types.ObjectId, ref: 'User'},
        phoneNumber: String,
        comments: [
            {
                userId: {type: mongoose.Schema.Types.ObjectId, ref: 'User'},
                comment: String
            }
        ]
    });

    var Event = mongoose.model('Event', eventSchema);

    Event.find({}).exec(function (err, collection) {
        if (err) {
            console.log('Cannot find events: ' + err);
            return;
        }

        if (collection.length === 0) {
            Event.create({
                title: 'Party event',
                description: 'Some words to test the description',
                location: {
                    latitude: 45.344322,
                    longitude: 52.434345
                },
                eventDate: Date.now(),
                category: 'Party',
                eventType: {
                    initiative: 'Software Academy',
                    season: 'Started 2013'
                },
                phoneNumber: '0888 123 456',
                comments: []
            }, function (err, event) {
                if (err) {
                    console.log('Event error: ' + err);
                }
            });

            Event.create({
                title: 'Free time event',
                description: 'Some words to test the description',
                location: {
                    latitude: 42.53533,
                    longitude: 39.54323
                },
                eventDate: Date.now(),
                category: 'Free time',
                eventType: {
                    initiative: 'Algo Academy',
                    season: 'Started 2013'
                },
                phoneNumber: '',
                comments: []
            }, function (err, event) {
                if (err) {
                    console.log('Event error: ' + err);
                }
            });

            console.log('Events added to database...');
        }
    });
};