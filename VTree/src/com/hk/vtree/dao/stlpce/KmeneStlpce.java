package com.hk.vtree.dao.stlpce;

public class KmeneStlpce {
    public static final String TABLE = "kmene";	
    public static final String MERANIE_ID          = "meranieID";
    public static final String CREATION_TIME = "creationtime";
    public static final String DREVINA_TYP          = "drevina_typ";    
    public static final String DREVINA_SIRKA          = "drevina_sirka";    
    public static final String DREVINA_DLZKA          = "drevina_dlzka";    
    public static final String DREVINA_OBJEM          = "drevina_objem";    
    protected static final String CREATION_TIME_TYPE   = "INTEGER NOT NULL";
    protected static final String MERANIE_ID_TYPE            = "INTEGER NOT NULL";
    protected static final String DREVINA_TYP_TYPE            = "TEXT";    
    protected static final String DREVINA_SIRKA_TYPE            = "REAL NOT NULL";
    protected static final String DREVINA_DLZKA_TYPE            = "REAL NOT NULL";
    protected static final String DREVINA_OBJEM_TYPE            = "REAL NOT NULL";    
    protected static final String _ID_TYPE             = "INTEGER PRIMARY KEY AUTOINCREMENT";
}
