var http = require('http');
var express = require('express');
http.createServer(function(req, res) {
    res.writeHead(200, {
        'Content-Type': 'text/plain'
    });
    res.end('Hello World\n');
}).listen(3000);
console.log('Server running at port 3000');