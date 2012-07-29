using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace StickyNote
{
	class Sticky
	{
		Main main;

		ArrayList StickyID = new ArrayList();

		public Sticky(Main m)
		{
			main = m;
		}

		public int AddSticky()
		{
			StickyForm form = new StickyForm(this);
		}

		struct Stickies
		{

		}

		internal void DeleteSticky(int formCount)
		{
			throw new NotImplementedException();
		}

		internal void exitApp(int p)
		{
			throw new NotImplementedException();
		}

		internal void ShowList(bool p)
		{
			throw new NotImplementedException();
		}
	}
}
