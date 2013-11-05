package com.hk.vtree;

public class vypocty {

	public static String tester (){
		String objem="1";
		
		return  objem;
	}
	
	
public static String getObjemZrdovina(double koeficient, String pocetKusov){
	int pocet = Integer.parseInt(pocetKusov);
	
	double objem = (pocet/100)*koeficient;
	String premenenyObjem = Double.toString(objem);
	return premenenyObjem;
}
	
	
	
	
	
	
	
	
	
	
	
}
