package com.hk.vtree.utils;

import java.util.HashMap;
import java.util.Map;

public class Constants {

	//konstanty pre vypocet; ak su to realne cisla, tak pouzit BigDecimal
	public static final Double PI = Math.PI;
	
	//konstanty pre vypocet objemu stromu bez kory - merany s korou
	//smrek
	public static final Double P0SM = 0.57723;
	public static final Double P1SM  = 0.006897;
	public static final Double P2SM = 1.3123;
	//dub
	public static final Double P0DB = 1.2474;
	public static final Double P1DB =0.042323;
	public static final Double P2DB =1.0623;
	//buk
	public static final Double P0BK =-0.04088;
	public static final Double P1BK =0.16634;
	public static final Double P2BK =0.56076;
	//borovica
	public static final Double P0BO=0.24017;
	public static final Double P1BO=0.001915;
	public static final Double P2BO=1.7866;
	//konstanty pre vypocet objemov pre zrde a zrdky
	public static final Double IHL_ZRDKY_1 = 0.15;
	public static final Double IHL_ZRDKY_2 = 0.35;
	public static final Double IHL_ZRDKY_3 = 0.85;
	public static final Double IHL_ZRDE_1 = 1.85;
	public static final Double IHL_ZRDE_2 = 3.35;
	public static final Double IHL_ZRDE_3 = 5.0;
	public static final Double IHL_ZRDE_4 = 7.35;
	public static final Double LIST_ZRDKY_1 = 0.3;
	public static final Double LIST_ZRDKY_2 = 0.7;
	public static final Double LIST_ZRDKY_3 = 1.05;
	public static final Double LIST_ZRDE_1 = 2.0;
	public static final Double LIST_ZRDE_2 = 3.5;
	public static final Double LIST_ZRDE_3 = 6.1;
	
	public static final String VOLUME_RESULT = "volume_result";
	
	
	// hodnoty pre dropdown
	public static final Map<String, String> KeyMap;

	public static final int DIALOG_LENGTH = 25;
	static {
		KeyMap = new HashMap<String, String>();
		KeyMap.put("Smrek", "sm");
		KeyMap.put("Borovica", "bo");
		KeyMap.put("Dub", "db");
		KeyMap.put("Buk", "bk");
	}

}
