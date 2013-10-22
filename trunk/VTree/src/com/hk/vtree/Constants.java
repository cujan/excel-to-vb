package com.hk.vtree;

import java.util.HashMap;
import java.util.Map;

public class Constants {

	//konstanty pre vypocet; ak su to realne cisla, tak pouzit BigDecimal
	public static final Double PI = Math.PI;
	

	public static final String VOLUME_RESULT = "volume_result";
	
	
	// hodnoty pre dropdown
	public static final Map<String, String> KeyMap;
	static {
		KeyMap = new HashMap<String, String>();
		KeyMap.put("Smrek", "sm");
		KeyMap.put("Dub", "db");
	}

}
