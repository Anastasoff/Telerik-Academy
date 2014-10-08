// Resources:
// https://github.com/felixge/node-formidable
// http://runnable.com/UkmAgT7F3K4tAAAn/uploading-files-with-formidable-for-node-js

var formidable = require('formidable'),
    http = require('http'),
    util = require('util'),
    PORT = 1234;

http.createServer(function (req, res) {
    if (req.url == '/upload' && req.method.toLowerCase() == 'post') {
        // parse a file upload
        var form = new formidable.IncomingForm();
        form.parse(req, function (err, fields, files) {
            res.writeHead(200, {'content-type': 'text/plain'});
            res.write('Received upload:\n\n');
            res.end(util.inspect(files));
        });
        return;
    }
    // show a file upload form
    res.writeHead(200, {'content-type': 'text/html'});
    res.end(
            '<form action="/upload" enctype="multipart/form-data" method="post">' +
            '<input type="file" name="upload" multiple="multiple"><br>' +
            '<input type="submit" value="Upload">' +
            '</form>'
    );
}).listen(PORT);

console.log('Server is running on port: ' + PORT);