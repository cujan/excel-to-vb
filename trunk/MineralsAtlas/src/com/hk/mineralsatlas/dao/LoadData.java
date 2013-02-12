package com.hk.mineralsatlas.dao;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import org.apache.http.NameValuePair;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import android.app.ListActivity;
import android.app.ProgressDialog;
import android.content.Context;
import android.content.res.Resources;
import android.os.AsyncTask;
import android.text.Html;
import android.text.Spanned;
import android.util.Log;
import android.view.View;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;

import com.hk.mineralsatlas.Constants;
import com.hk.mineralsatlas.R;

public class LoadData extends AsyncTask<String, String, String> {

	private static final String TAG_SUCCESS = "success";

	private String dataType;
	private String[] dataEntities;

	// Progress Dialog
	private ProgressDialog pDialog;

	private ListActivity parentContext;

	private int layoutId;

	private String urlToData;

	private int[] dataEntityIds;

	// Creating JSON Parser object
	JSONParser jParser = new JSONParser();

	JSONArray entity = null;

	ArrayList<HashMap<String, Spanned>> dataList = new ArrayList<HashMap<String, Spanned>>();

	public LoadData(ListActivity ctx, String url, String dType, int layId,
			String[] dEntities, int[] cIds) {
		super();
		parentContext = ctx;
		jParser.setTimeoutConnection(Constants.TIMEOUT_CONNECTION);
		urlToData = url;
		dataType = dType;
		dataEntities = dEntities;
		dataEntityIds = cIds;
		layoutId = layId;
	}

	/**
	 * Before starting background thread Show Progress Dialog
	 * */
	@Override
	protected void onPreExecute() {
		super.onPreExecute();
		Resources res = parentContext.getResources();
		pDialog = new ProgressDialog(parentContext);
		pDialog.setMessage(res.getString(R.string.loading_data));
		pDialog.setIndeterminate(false);
		pDialog.setCancelable(false);
		pDialog.show();
	}

	/**
	 * getting All products from url
	 * */
	@Override
	protected String doInBackground(String... args) {
		// Building Parameters
		List<NameValuePair> params = new ArrayList<NameValuePair>();

		try {
			// getting JSON string from URL
			JSONObject json = jParser
					.makeHttpRequest(urlToData, "POST", params);

			if (json == null)
				return null;

			// Check your log cat for JSON reponse
			Log.d("All Data: ", json.toString());

			// Checking for SUCCESS TAG
			int success = json.getInt(TAG_SUCCESS);

			if (success == 1) {
				// products found
				// Getting Array of Products
				entity = json.getJSONArray(dataType);

				// looping through All Products
				for (int i = 0; i < entity.length(); i++) {
					JSONObject c = entity.getJSONObject(i);

					// creating new HashMap
					HashMap<String, Spanned> map = new HashMap<String, Spanned>();
					for (int j = 0; j < dataEntities.length; j++) {
						// adding each child node to HashMap key => value
						map.put(dataEntities[j], Html.fromHtml(c.getString(dataEntities[j]).replaceAll("\\/", "/")));
					}

					// adding HashList to ArrayList
					if (!map.isEmpty()) {
						dataList.add(map);
					}
				}

			}
		} catch (JSONException e) {
			e.printStackTrace();
		}

		return null;
	}

	/**
	 * After completing background task Dismiss the progress dialog
	 * **/
	@Override
	protected void onPostExecute(String file_url) {
		// dismiss the dialog after getting all products
		pDialog.dismiss();
		parentContext.runOnUiThread(new Runnable() {
			@Override
			public void run() {
				if (dataList == null || dataList.isEmpty()) {
					Resources res = parentContext.getResources();	
					Toast.makeText(parentContext, res.getString(R.string.no_data_found),Toast.LENGTH_SHORT).show();
					return;
				}

				/**
				 * Updating parsed JSON data into ListView
				 * */
				SimpleAdapter adapter = new SimpleAdapter(parentContext,
						dataList, layoutId, dataEntities, dataEntityIds);
			    adapter.setViewBinder(new SimpleAdapter.ViewBinder() {  
			        public boolean setViewValue(View view, Object data, String textRepresentation) {  
			            if (data instanceof Spanned && view instanceof TextView) {  
			                ((TextView) view).setText((Spanned) data);  
			            } else {  
			                ((TextView) view).setText(String.valueOf(data));  
			            }  
			            return true;  
			            }  
			        }  
			    );  
				
				// updating listview
				parentContext.setListAdapter(adapter);
			}
		});
	}

	public Context getParentContext() {
		return parentContext;
	}

	public void setParentContext(ListActivity parentContext) {
		this.parentContext = parentContext;
	}

	public String getDataType() {
		return dataType;
	}

	public void setDataType(String dataType) {
		this.dataType = dataType;
	}

	public String[] getDataEntities() {
		return dataEntities;
	}

	public void setDataEntities(String[] dataEntities) {
		this.dataEntities = dataEntities;
	}

	public ArrayList<HashMap<String, Spanned>> getDataList() {
		return dataList;
	}

	public void setDataList(ArrayList<HashMap<String, Spanned>> dataList) {
		this.dataList = dataList;
	}

}
