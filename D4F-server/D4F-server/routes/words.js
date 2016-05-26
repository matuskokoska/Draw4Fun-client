var express = require('express');
var router = express.Router();
var bodyParser = require("body-parser");
var words = require(appRoot + "/API/words");

router.get('/', function (req, res) {
  var data=[];
  var i;
  for(i=1;i<=5;i++){
    (function(i){
      words.getRandomWord(i,function(result){
        console.log(result);
        data.push(result);
        if(i==5){
          res.json(data);
        }
      });
    })(i);
  }
});

module.exports = router;
