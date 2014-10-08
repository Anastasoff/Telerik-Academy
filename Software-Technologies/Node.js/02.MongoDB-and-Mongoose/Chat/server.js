'use strict';

var connectionString = 'localhost:27017/chat';
require('./server/config/mongoose')(connectionString);

var chatDb = require('./server/data/chat-db');

// Please test every functionality one-by-one

chatDb.registerUser({user: 'DonchoMinkov', pass: 'dron40'});
chatDb.registerUser({user: 'NikolayKostov', pass: 'nikiniki'});

//chatDb.sendMessage({
//    from: 'DonchoMinkov',
//    to: 'NikolayKostov',
//    text: 'Hey, Niki!'
//});
//
//chatDb.sendMessage({
//    from: 'NikolayKostov',
//    to: 'DonchoMinkov',
//    text: 'Hey, there!'
//});

//chatDb.getMessages({
//    with: 'DonchoMinkov',
//    and: 'NikolayKostov'
//}, function (error, results) {
//    if (error) {
//        console.log(error);
//        return;
//    }
//
//    console.log('Messages');
//    for (var prop in results) {
//        var msg = results[prop];
//        console.log(msg.from.user + ': ' + msg.text);
//    }
//});