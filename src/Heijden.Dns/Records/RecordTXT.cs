using System;
using System.Collections.Generic;

#region Rfc info
/*
3.3.14. TXT RDATA format

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                   TXT-DATA                    /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

TXT-DATA        One or more <character-string>s.

TXT RRs are used to hold descriptive text.  The semantics of the text
depends on the domain where it is found.
 * 
*/
#endregion

namespace Heijden.DNS
{
	public class RecordTXT : Record
	{
		public List<string> TXT;

		public RecordTXT(RecordReader rr)
		{
			// TXT = rr.ReadString();
			TXT = rr.ReadCharacterStrings();
		}

		public override string ToString()
		{
			//return string.Format("\"{0}\"",TXT);
			return string.Join("", TXT.ToArray());
		}

		public List<string> GetTXT()
		{
			return this.TXT;
		}

	}
}
