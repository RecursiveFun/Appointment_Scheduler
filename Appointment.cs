using System;

public class Appointment
{
	//create public props for the time being and figure out access later if these are even required for this program
	public int userID { get; set; }
	public int appointmentID {get; set; }
	public int customerID { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public string Location { get; set; }
	public string Contact { get; set; }
	public string Type { get; set; }
	public string URL { get; set; }
	public DateTime Start { get; set; }
	public DateTime End { get; set; }
	public DateTime CreateDate { get; set; }
	public string CreatedBy { get; set; }
	public DateTime LastUpdate { get; set; }
	public string LastUpdateBy { get; set; }

	//default constructor
	public Appointment()
	{

	}
}
