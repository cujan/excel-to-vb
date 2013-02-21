package com.hk.mineralsatlas;

import java.util.HashMap;
import java.util.Map;

public class Constants {

	public static final String EXTRA_ACTION = "action";
	public static final String EXTRA_ACTION_KEY = "action_key";
	public static final String EXTRA_URL = "url";
	public static final String EXTRA_PATH = "path";

	public static final String MINERALS_LIST = "minerals_list";
	public static final String LOCATIONS_LIST = "locations";
	public static final String KEY_SEARCH = "key_search";	

	public static final String ACTION_MINERALS_LIST = "minerals.php";
	public static final String ACTION_MINERALS_SEARCH = "searchMinerals.php?";	
	public static final String ACTION_LOCATIONS_LIST = "locations.php";
	public static final String ACTION_MAP = "https://maps.google.com/maps?q=";
	public static final String ACTION_PHOTOS = "getMineralsPhoto.php?idMineral=";
	public static final String ACTION_MINERALS_DETAIL = "mineralsDetail.php?id=";

	public static final int TIMEOUT_CONNECTION = 15000;

	public static final String MINERALS_DATA_TYPE = "mineraly";
	public static final String LOCATIONS_DATA_TYPE = "naleziska";
	public static final String ENTRY_ID = "id";
	public static final String GROUP = "nazovSkupina";
	public static final String NAME = "nazov";
	public static final String FORMULA = "chemickeZlozenie";

	public static final String OKRES = "okres";
	public static final String GEOMORFOLOGICKY_CELOK = "geomorfologickyCelok";
	public static final String CHARAKTERISTIKA = "charakteristika";
	public static final String GEOLOGICKY_CELOK = "geologickyCelok";
	public static final String HORNINOVE_ZLOZENIE = "horninoveZlozenie";
	public static final String ZEMEPISNA_SIRKA = "zemepisnaSirka";
	public static final String ZEMEPISNA_DLZKA = "zemepisnaDlzka";
	public static final String MINERALY = "mineraly";

	public static final String[] COLUMNS_MINERALS_LIST = { GROUP, NAME,
			FORMULA, ENTRY_ID };
	public static final int[] COLUMN_IDS_MINERALS_LIST = { R.id.group,
			R.id.name, R.id.formula, R.id.entry_id };

	public static final String[] COLUMNS_LOCATIONS_LIST = { NAME, OKRES,
			GEOMORFOLOGICKY_CELOK, GEOLOGICKY_CELOK, CHARAKTERISTIKA,
			HORNINOVE_ZLOZENIE, MINERALY, ZEMEPISNA_SIRKA, ZEMEPISNA_DLZKA,
			ENTRY_ID };

	public static final int[] COLUMN_IDS_LOCATIONS_LIST = { R.id.name,
			R.id.okres, R.id.geomorfologicky_celok, R.id.geologicky_celok,
			R.id.charakteristika, R.id.horninove_zlozenie, R.id.mineraly,
			R.id.zemepisna_sirka, R.id.zemepisna_dlzka, R.id.entry_id };

	
	// for minerals details
	public static final String MINERALS_DETAIL_DATA_TYPE = "detail";
	public static final String MINERALS_DETAIL_CHEMICKE_ZLOZENIE = "chemickeZlozenie";
	public static final String MINERALS_DETAIL_SKUPINA_NAZOV = "skupinaNazov";
	public static final String MINERALS_DETAIL_KR_SKUPINA = "krystalografickaSustava";
	public static final String MINERALS_DETAIL_VRYP = "vryp";
	public static final String MINERALS_DETAIL_TVRDOST_OD = "tvrdostOd";
	public static final String MINERALS_DETAIL_TVRDOST_DO = "tvrdostDo";
	public static final String MINERALS_DETAIL_STIEPITELNOST = "stiepatelnost";
	public static final String MINERALS_DETAIL_HUSTOTA_DO = "hustotaDo";
	public static final String MINERALS_DETAIL_HUSTOTA_OD = "hustotaOd";

	public static final String[] COLUMNS_MINERALS_DETAIL = { ENTRY_ID, NAME,
			MINERALS_DETAIL_CHEMICKE_ZLOZENIE, MINERALS_DETAIL_SKUPINA_NAZOV,
			MINERALS_DETAIL_KR_SKUPINA, MINERALS_DETAIL_VRYP,
			MINERALS_DETAIL_TVRDOST_OD, MINERALS_DETAIL_TVRDOST_DO,
			MINERALS_DETAIL_STIEPITELNOST, MINERALS_DETAIL_HUSTOTA_OD,
			MINERALS_DETAIL_HUSTOTA_DO };
	
	public static final int[] COLUMN_IDS_MINERALS_DETAIL = { R.id.entry_id,
			R.id.name, R.id.chemicke_zlozenie, R.id.skupina_nazov, R.id.krystalograficka_sustava, R.id.vryp, R.id.tvrdost_od, R.id.tvrdost_do,R.id.stiepatelnost, R.id.hustota_od,R.id.hustota_do  };

    public static final Map<String, String> KeyMap;
    static {
        KeyMap = new HashMap<String, String>();
        KeyMap.put("biely","biely");
        KeyMap.put("kovový","kovovy");        
    }
	
}
