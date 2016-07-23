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
};

