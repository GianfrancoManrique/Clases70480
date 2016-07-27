onmessage=function(event){


	postMessage("Valor recibido: "+event.data);
	postMessage("Los siguientes son números primos: "+obtenerPrimos(event.data))

}

function obtenerPrimos(numLimite){

	var numPrimos="";

	for (var i = 0;i<= numLimite; i++) {
		
		if(esPrimo(i)){

			numPrimos+=i+" ";

		}
	};

	return numPrimos;
}

function esPrimo(num){

	if(num<2){

		return false;

	}else{

		var raiz=Math.sqrt(num);

		for (i =2; i <= raiz; i++) {
		
			if(num%i==0) return false
				
		}
	};

	return true;

}