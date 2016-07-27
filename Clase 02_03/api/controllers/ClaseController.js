/**
 * GeolocalizaController
 *
 * @description :: Server-side logic for managing Geolocalizas
 * @help        :: See http://sailsjs.org/#!/documentation/concepts/Controllers
 */

module.exports = {
	
	Geolocalizacion:function(req,res){
		res.view("01-geolocalizacion");
	},

	Expresiones:function(req,res){
		res.view("02-expresiones");
	},

	WebWorkers:function(req,res){
		res.view("03-webworkers");
	},

	WebSockets:function(req,res){
		res.view("04-websockets");
	}

};

