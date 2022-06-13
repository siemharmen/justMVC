"use strict";function _classCallCheck(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}function _defineProperties(e,t){for(var n=0;n<t.length;n++){var a=t[n];a.enumerable=a.enumerable||!1,a.configurable=!0,"value"in a&&(a.writable=!0),Object.defineProperty(e,a.key,a)}}function _createClass(e,t,n){return t&&_defineProperties(e.prototype,t),n&&_defineProperties(e,n),Object.defineProperty(e,"prototype",{writable:!1}),e}function toggleFeedback(e){e=document.getElementById(e);"none"===e.style.display?$(e).attr("style","display:block"):$(e).attr("style","display:none")}var FeedbackWidget=function(){function t(e){_classCallCheck(this,t),this._elementId=e,this.Messages=[]}return _createClass(t,[{key:"elementId",get:function(){return this._elementId}},{key:"show",value:function(e,t){var n=document.getElementById(this.elementId);$(n).text(e);try{"none"===n.style.display&&toggleFeedback(this.elementId)}catch(e){}"success"===t?($(n).attr("style","background:lightgreen"),t="success"):$(n).attr("style","background:red"),this.log({message:e,type:t})}},{key:"hide",value:function(){"none"!==document.getElementById(this.elementId).style.display&&toggleFeedback(this.elementId)}},{key:"log",value:function(e){this.Messages.push(e),10<this.Messages.length&&this.Messages.shift(),localStorage.setItem("feedback_widget",JSON.stringify(this.Messages))}},{key:"removeLog",value:function(){localStorage.removeItem("feedback_widget"),this.Messages=[]}},{key:"history",value:function(){var t="";return JSON.parse(localStorage.getItem("feedback_widget")).forEach(function(e){"success"===e.type?t+="success - ":t+="error - ",t+=e.message+"<br><br>"}),t}}]),t}(),apiUrl=($(document).ready(function(){new FeedbackWidget("feedback-danger").show("Ready danger","adf")}),"url/super/duper/game"),Game=function(){var e={apiUrl:apiUrl};return{init:function(){console.log(e.apiUrl)}}}();Game.Reversi={init:function(){Game.init()},showFiche:function(e,t){e=document.getElementById(e);"zwart"===t?e.classList.add("black"):e.classList.add("white"),e.classList.add("fade-in")}},Game.Model=function(){var a={gameState:""};return{init:function(){Game.init()},getWeather:function(e){Promise.resolve(Game.Data.get(e)).then(function(e){console.log(e.main.temp),"number"==typeof e.main.temp?console.log("geeft temperatuur"):console.error("error")},function(e){console.error("error")}),Game.Data.get(e).then(function(e){return console.log(e.main.temp)})},getGameState:function(){var t=0;setInterval(function(){var n;Game.Data.get("api/Spel/Beurt/").then(function(e){t=e}),n=t,new Promise(function(e,t){0===n?a.gameState=0:1===n?a.gameState=1:2===n?a.gameState=2:t(new Error("Getal is niet binnen de critiria"))}).then().catch(function(e){return console.log("Foute waarde")}),console.log(a.gameState)},2e3)}}}(),Game.Data=function(){function t(t){var n=e.mock.find(function(e){return e.url===t}).data;return new Promise(function(e,t){e(n)})}var e={apiKey:"aa6bb372c0ccba60aff08f3c0b3cf922",mock:[{url:"api/Spel/Beurt/",data:1}]},n="development";return{init:function(){return"production"===n?$.get(e.mock[0].url):"development"===n?t("api/Spel/Beurt/"):void new Error("error")},get:function(e){return"development"===n?t(e):$.get(e).then(function(e){return e}).catch(function(e){console.log(e.message)})}}}();