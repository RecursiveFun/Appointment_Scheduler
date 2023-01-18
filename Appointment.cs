using System;

public class Appointment
{
	//create private fields
	private int _appointmentID;
	private int _customerID;
	private int _userID;
	private string _title;
	private string _description;
	private string _location;
	private string _contact;
	private string _type;
	private string _url;
	private DateTime _start;
	private DateTime _end;
	private DateTime _createDate;
	private string _createdBy;
	private DateTime _lastUpdate;
	private string _lastUpdateBy;

	//create public getters/setters
	public int ID
	{
		get
		{
			return _appointmentID;
		}
	}

	public int CustomerID
	{
		get
		{
			return _customerID;
		}
	}

	public int UserID
	{
		get
		{
			return _userID;
		}
	}

	public string Title
	{
		get 
		{ 
			return _title;
		}
		set
		{
			_title = value;
		}
	}

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = value;
		}
	}

	public string Location
	{
		get
		{
			return _location;
		}
		set
		{
			_location = value;
		}
	}

	public string Contact
	{
		get
		{
			return _contact;
		}
		set
		{
			_contact = value;
		}
	}

	public string Type
	{
		get
		{
			return _type;
		}
		set
		{
			_type = value;
		}
	}

	public string URL
	{
		get
		{
			return _url;
		}
		set
		{
			_url = value;
		}
	}

	public DateTime Start
	{
		get
		{
			return _start;
		}
		set
		{
			_start = value;
		}
	}

	public DateTime End
	{
		get
		{
			return _end;
		}
		set
		{
			_end = value;
		}
	}

	public DateTime CreateDate
	{
		get
		{
			return _createDate;
		}
	}

	public string CreatedBy
	{
		get
		{
			return _createdBy;
		}
	}

	public DateTime LastUpdate
	{
		get
		{
			return _lastUpdate;
		}
		set
		{
			_lastUpdate = value;
		}
	}

	public string LastUpdatedBy
	{
		get
		{
			return _lastUpdateBy;
		}
		set
		{
			_lastUpdateBy = value;
		}
	}

	//constructor with params
	public Appointment(int appointmentID, int customerID, int userID, string title, string description,
		string location, string contact, string type, string url, DateTime start, DateTime end,
		DateTime createDate, string createdBy, DateTime lastUpdate, string lastupdatedBy)
	{
		this._appointmentID = appointmentID;
		this._customerID = customerID;
		this._userID = userID;
		this._title = title;
		this._description = description;
		this._location = location;
		this._contact = contact;
		this._type = type;
		this._url = url;
		this._start = start;
		this._end = end;
		this._createDate = createDate;
		this._createdBy = createdBy;
		this._lastUpdate = lastUpdate;
		this._lastUpdateBy = lastupdatedBy;
	}

	//default constructor
	public Appointment() { }
}
