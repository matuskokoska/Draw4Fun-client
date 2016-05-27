var express = require('express');
var router = express.Router();
var bodyParser = require("body-parser");
var drawings = require(appRoot + "/API/drawings");


router.post('/new', function (req, res) {
    var wordid = req.body.wordid;
    var painter = req.body.painter;
    var receiver = req.body.receiver;
    var stream = req.body.stream;
	  drawings.new(wordid,painter, receiver, stream, function (success) {
		console.log(success);
		res.json(success);
	});
});

router.post('/get', function(req, res){
    var userid = req.body.userid;
    drawings.get(userid,function(results){
      res.json(results);
    })
});

router.post('/stream', function(req, res){
    var id = req.body.id;
    drawings.getStream(id,function(results){
      res.json(results);
    })
});



module.exports = router;
