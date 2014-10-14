var path = require('path');
var rootPath = path.normalize(__dirname + '/../../');
var DB_NAME = 'eventsDb';
var PORT = 1234;

module.exports = {
    development: {
        rootPath: rootPath,
        databaseConnection: 'mongodb://localhost:27017/' + DB_NAME,
        port: process.env.PORT || PORT
    }
};