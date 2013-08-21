package com.hk.woodenchurches;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.AnimationUtils;
import android.widget.AdapterView;
import android.widget.BaseAdapter;
import android.widget.Gallery;
import android.widget.Gallery.LayoutParams;
import android.widget.ImageSwitcher;
import android.widget.ImageView;
import android.widget.ViewSwitcher;

import com.actionbarsherlock.app.SherlockFragment;

public class ChurchGallery extends SherlockFragment implements
		AdapterView.OnItemSelectedListener, ViewSwitcher.ViewFactory {

	private View mRoot;
	private Context ctx;

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		// requestWindowFeature(Window.FEATURE_NO_TITLE);
		mRoot = inflater.inflate(R.layout.church_gallery, null);
		ctx = getActivity();
		mSwitcher = (ImageSwitcher) mRoot.findViewById(R.id.switcher);
		mSwitcher.setFactory(this);
		mSwitcher.setInAnimation(AnimationUtils.loadAnimation(ctx,
				android.R.anim.fade_in));
		mSwitcher.setOutAnimation(AnimationUtils.loadAnimation(ctx,
				android.R.anim.fade_out));

		Gallery g = (Gallery) mRoot.findViewById(R.id.gallery);
		g.setAdapter(new ImageAdapter(ctx));
		g.setOnItemSelectedListener(this);

		return mRoot;
	}

	public void onItemSelected(AdapterView<?> parent, View v, int position,
			long id) {
		mSwitcher.setImageResource(mImageIds[position]);
	}

	public void onNothingSelected(AdapterView<?> parent) {
	}

	public View makeView() {
		ImageView i = new ImageView(ctx);
//		i.setBackgroundColor(0xFF000000);
		i.setScaleType(ImageView.ScaleType.FIT_CENTER);
		i.setLayoutParams(new ImageSwitcher.LayoutParams(
				LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT));
		return i;
	}

	private ImageSwitcher mSwitcher;

	public class ImageAdapter extends BaseAdapter {
		public ImageAdapter(Context c) {
			mContext = c;
		}

		public int getCount() {
			return mThumbIds.length;
		}

		public Object getItem(int position) {
			return position;
		}

		public long getItemId(int position) {
			return position;
		}

		public View getView(int position, View convertView, ViewGroup parent) {
			ImageView i = new ImageView(mContext);

			i.setImageResource(mThumbIds[position]);
			i.setAdjustViewBounds(true);
			i.setLayoutParams(new Gallery.LayoutParams(
					LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT));
			// i.setBackgroundResource(R.drawable.picture_frame);
			return i;
		}

		private Context mContext;

	}

	private Integer[] mThumbIds = { R.drawable.ic_launcher,
			R.drawable.ic_launcher_web };

	private Integer[] mImageIds = { R.drawable.ic_launcher,
			R.drawable.ic_launcher_web};

}