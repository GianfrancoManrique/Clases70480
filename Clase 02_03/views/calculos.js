onmessage=function(event){
	postMessage("Recibido el siguiente valor"+event.data);
	postMessage("Los siguientes son números primos"+obtenePrimos(event.data))
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
	}

	var raiz=Math.sqrt(num);

	for (i =2; i <= raiz; i++) {
		
		if(num%i==0) return false
	};

	return true;

}