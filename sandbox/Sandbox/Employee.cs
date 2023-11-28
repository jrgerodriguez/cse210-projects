// the parent class showing the "virtual" keyword included
public abstract class Employee
{

  protected string _employeeName;

  public void SetName(string name)
  {
    _employeeName = name;
  }

  public string GetName()
  {
    return _employeeName;
  }

  // Notice the abstract method doesn't have a body at all (not even an empty one)
  // and it is followed by a semicolon.
  public abstract float CalculatePay();
  
}