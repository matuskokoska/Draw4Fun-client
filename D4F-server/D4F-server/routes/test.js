var express = require('express');
var db = require(appRoot + '/API/DBconnect.js');
var router = express.Router();

/* GET users listing. */
router.post('/test', function (req, res) {
    getBinaryData(req.url,
        function (answer) {
            res.type('jpg');
            res.end(new Buffer(answer, 'binary'));
        },
        function (error) {
            res.setHeader('Content-Type', 'text/plain');
            return res.end(error);
        }
    );
});

router.post('/', function (req, res) {
	console.log(req.binary);
	res.json(req.binary);
});

module.exports = router;
