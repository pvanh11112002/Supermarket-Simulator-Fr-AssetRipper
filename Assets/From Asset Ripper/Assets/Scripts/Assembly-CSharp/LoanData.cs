using System;

[Serializable]
public class LoanData
{
	public int LoanID;

	public int TermLength;

	public int RemainingPayments;

	public bool Taken;

	public void Reset()
	{
	}
}
