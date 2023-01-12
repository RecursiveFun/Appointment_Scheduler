using System;

public class Customer
{
	//Create AssociatedCustomers BindingList<Customer>
	//public BindingList<Customer> AssociatedCustomers = new BindingList<Customer>();
	
	//create public props for the time being and figure out access later if these are even needed for this program
	public string CustomerName { get; set; }
	public string Address { get; set; }
	public string Address2 { get; set; }
	public string City { get; set; }
	public string Country { get; set; }
	public int Phone { get; set; }

	//default constructor
	public Customer()
	{
	}
}
