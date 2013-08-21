package com.hk.woodenchurches;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.actionbarsherlock.app.SherlockFragment;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;

public class ChurchDetails extends SherlockFragment {

	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		View root = inflater.inflate(R.layout.church_detail, container, false);

		if (isGoogleMapsInstalled()) {

			GoogleMap mMap;
			mMap = ((SupportMapFragment) getFragmentManager().findFragmentById(
					R.id.map)).getMap();
			if (mMap != null)
				mMap.addMarker(new MarkerOptions().position(
						new LatLng(49.354167, 21.707222)).title("Kostol"));
		} 
		return root;
	}

	public boolean isGoogleMapsInstalled() {
		try {
			Context ctx = getActivity();
			ApplicationInfo info = ctx.getPackageManager().getApplicationInfo(
					"com.google.android.apps.maps", 0);
			return true;
		} catch (PackageManager.NameNotFoundException e) {
			return false;
		}
	}

}
