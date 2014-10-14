var mongoose = require('mongoose');
var encryption = require('../../utilities/encryption');

module.exports.init = function () {
    var userSchema = mongoose.Schema({
        username: { type: String, require: '{PATH} is required', unique: true, validate: [validator, 'Username must be at least 6 symbols long'] },
        salt: String,
        hashPass: String,
        firstName: { type: String, require: '{PATH} is required' },
        lastName: { type: String, require: '{PATH} is required' },
        phoneNumber: {type: String, default: ''},
        email: { type: String, require: '{PATH} is required' },
        eventPoints: {
            organization: { type: Number, min: 0, default: 0},
            venue: { type: Number, min: 0, default: 0}
        },
        initiatives: [
            {type: String, enum: ['Software Academy', 'Algo Academy', 'School Academy', 'Kids Academy']}
        ],
        seasons: [
            {type: String, enum: ['Started 2010', 'Started 2011', 'Started 2012', 'Started 2013']}
        ],
        avatar: {type: String, default: ''},
        links: [
            {type: String, default: ''}
        ]
    });

    function validator(v) {
        return v.length > 5;
    }

    userSchema.method({
        authenticate: function (password) {
            if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
                return true;
            }
            else {
                return false;
            }
        }
    });

    var User = mongoose.model('User', userSchema);

    User.find({}).exec(function (err, collection) {
        if (err) {
            console.log('Cannot find users: ' + err);
            return;
        }

        if (collection.length === 0) {
            var salt;
            var hashedPwd;

            salt = encryption.generateSalt();
            hashedPwd = encryption.generateHashedPassword(salt, 'pesho');
            User.create({username: 'Pesho1', firstName: 'Pesho', lastName: 'Peshov', salt: salt, hashPass: hashedPwd, phoneNumber: '0888123456', email: 'pesho@abv.bg', initiatives: 'Software Academy', seasons: 'Started: 2013'});

            salt = encryption.generateSalt();
            hashedPwd = encryption.generateHashedPassword(salt, 'gosho');
            User.create({username: 'Gosho1', firstName: 'Gosho', lastName: 'Goshev', salt: salt, hashPass: hashedPwd, phoneNumber: '0888654321', email: 'gosho@abv.bg', initiatives: 'Algo Academy', seasons: 'Started: 2012'});

            console.log('Users added to database...');
        }
    });
};
