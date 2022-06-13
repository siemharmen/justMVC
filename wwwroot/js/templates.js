this["spa_templates"] = this["spa_templates"] || {};
this["spa_templates"]["feedbackWidget"] = this["spa_templates"]["feedbackWidget"] || {};
this["spa_templates"]["feedbackWidget"]["body"] = Handlebars.template({"compiler":[8,">= 4.3.0"],"main":function(container,depth0,helpers,partials,data) {
    var helper, lookupProperty = container.lookupProperty || function(parent, propertyName) {
        if (Object.prototype.hasOwnProperty.call(parent, propertyName)) {
          return parent[propertyName];
        }
        return undefined
    };

  return "<section class=\"body\">\r\n    "
    + container.escapeExpression(((helper = (helper = lookupProperty(helpers,"bericht") || (depth0 != null ? lookupProperty(depth0,"bericht") : depth0)) != null ? helper : container.hooks.helperMissing),(typeof helper === "function" ? helper.call(depth0 != null ? depth0 : (container.nullContext || {}),{"name":"bericht","hash":{},"data":data,"loc":{"start":{"line":2,"column":4},"end":{"line":2,"column":15}}}) : helper)))
    + "\r\n</section>";
},"useData":true});
this["spa_templates"]["feedbackWidget"]["Stand"] = Handlebars.template({"compiler":[8,">= 4.3.0"],"main":function(container,depth0,helpers,partials,data) {
    var helper, alias1=depth0 != null ? depth0 : (container.nullContext || {}), alias2=container.hooks.helperMissing, alias3="function", alias4=container.escapeExpression, lookupProperty = container.lookupProperty || function(parent, propertyName) {
        if (Object.prototype.hasOwnProperty.call(parent, propertyName)) {
          return parent[propertyName];
        }
        return undefined
    };

  return "<ul></ul>\r\n<div class=\"SubNotice LengthNotice\">\r\n    Zwart:\r\n    <a>"
    + alias4(((helper = (helper = lookupProperty(helpers,"Zwart") || (depth0 != null ? lookupProperty(depth0,"Zwart") : depth0)) != null ? helper : alias2),(typeof helper === alias3 ? helper.call(alias1,{"name":"Zwart","hash":{},"data":data,"loc":{"start":{"line":4,"column":7},"end":{"line":4,"column":16}}}) : helper)))
    + "</a>\r\n</div>\r\n\r\n<ul></ul>\r\n\r\n<div class=\"SubNotice LengthNotice\">\r\n    Wit:\r\n    <a>"
    + alias4(((helper = (helper = lookupProperty(helpers,"Wit") || (depth0 != null ? lookupProperty(depth0,"Wit") : depth0)) != null ? helper : alias2),(typeof helper === alias3 ? helper.call(alias1,{"name":"Wit","hash":{},"data":data,"loc":{"start":{"line":11,"column":7},"end":{"line":11,"column":14}}}) : helper)))
    + "</a>\r\n</div>\r\n<ul></ul>\r\n";
},"useData":true});
this["spa_templates"]["feedbackWidget"]["stats"] = Handlebars.template({"compiler":[8,">= 4.3.0"],"main":function(container,depth0,helpers,partials,data) {
    return "<div>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js\"></script>\r\n    <canvas id=\"myChart\" width=\"400\" height=\"400\"></canvas>\r\n\r\n</div>\r\n<script>\r\n    var ctx = document.getElementById(\"myChart\");\r\n    var test = \"line\";\r\n    var labels =[\"1\", \"5\", \"3\", \"4\", \"4\", \"5\"];\r\n    var datazwart = [12, 19, 3, 5, 2, 3];\r\n    var datawit = [1, 4, 8, 16, 32, 12];\r\n    var myChart = new Chart(ctx, {\r\n        type: test,\r\n        data: {\r\n            labels: labels,\r\n            datasets: [\r\n                {\r\n                    label: \"# of Votes\",\r\n                    data: datazwart,\r\n                    //borderColor: '#b9c246',\r\n                },\r\n                {\r\n                    label: \"# of Votes\",\r\n                    data: datawit,\r\n                    //borderColor: '#e2431e',\r\n                }\r\n            ]\r\n        },\r\n        options: {\r\n            borderColor: ['#e2431e', '#b9c246', '#d3362d', '#e7711b','#e49307', '#e49307'],\r\n            scales: {\r\n                y: {\r\n                    ticks: {\r\n                        beginAtZero: true\r\n                    }\r\n                }\r\n            }\r\n        }\r\n    });\r\n\r\n</script>";
},"useData":true});