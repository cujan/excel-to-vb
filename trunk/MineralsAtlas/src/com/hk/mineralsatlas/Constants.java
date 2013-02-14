package com.hk.mineralsatlas;

public class Constants {

	public static final String EXTRA_ACTION = "action";
	public static final String EXTRA_ACTION_KEY = "action_key";
	public static final String EXTRA_URL = "url";
	public static final String EXTRA_PATH = "path";

	public static final String MINERALS_LIST = "minerals_list";
	public static final String LOCATIONS_LIST = "locations";

	public static final String ACTION_MINERALS_LIST = "minerals.php";
	public static final String ACTION_LOCATIONS_LIST = "locations.php";
	public static final String ACTION_MAP = "https://maps.google.com/maps?q=";
	public static final String ACTION_PHOTOS = "getMineralsPhoto.php?id=";
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

}
