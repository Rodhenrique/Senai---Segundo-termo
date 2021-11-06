var request = require('request');
var cheerio = require('cheerio');

request('URL DO SITE', function(err, res, body){
    if (err) console.log('Erro: ' + err) 

    var $ = cheerio.load(body);

    $('div principal').each(function() {
        var title = $(this).find('tag da aonde quer pegar').text().trim();

        console.log('valor: ' + title);
    });
});