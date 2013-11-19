package com.hk.vtree.utils;

public class vypocty {

	public static String tester (){
		String objem="1";
		
		return  objem;
	}
	
	//vrati objem zrde a zrdky podla poctu kosov a prislusneho koeficientu
public static double getObjemZrdovina(double koeficient, int pocetKusov){
	
	double objem = (pocetKusov*koeficient)/100;
	double zaokruhlenyObjem = Math.round(objem*100)/100D;
	return zaokruhlenyObjem;
}
	
	
	
	
	
	
	
	
	
	
	
}
