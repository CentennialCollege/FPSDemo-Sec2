using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public Text scoreLabel;
	public Text lifeLabel;

	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue = 0;
	private int _liveValue = 100;

	// PUBLIC PROPERTIES
	public int Score {
		get {
			return _scoreValue;
		}
		set {
			_scoreValue = value;
			this._updateHUD();
		}
	}

	public int Life {
		get {
			return _liveValue;
		}
		set {
			_liveValue = value;
			this._updateHUD();
		}
	}

	// Use this for initialization
	void Start () {
		this._updateHUD ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// PRIVATE METHODS
	private void _updateHUD() {
		this.scoreLabel.text = "Score: " + this._scoreValue;
		this.lifeLabel.text = "Life: " + this._liveValue;
	}
}
