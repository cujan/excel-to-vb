package com.hk.vtree;

import java.util.HashMap;
import java.util.Map;

public class Constants {

	//konstanty pre vypocet; ak su to realne cisla, tak pouzit BigDecimal
	public static final Double PI = Math.PI;
	
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
	static {
		KeyMap = new HashMap<String, String>();
		KeyMap.put("Smrek", "sm");
		KeyMap.put("Borovica", "bo");
		KeyMap.put("Dub", "db");
		KeyMap.put("Buk", "bk");
	}

}
