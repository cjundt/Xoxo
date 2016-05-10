//
//  This file is part of Diwen.xbrl.
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2015-2016 John Nordberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Diwen.Xbrl
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;

	public class FilingIndicatorCollection : Collection<FilingIndicator>, IEquatable<IList<FilingIndicator>>
	{
		public FilingIndicator Add(Context context, string value)
		{
			return Add(context, value, true);
		}

		public FilingIndicator Add(Context context, string value, bool filed)
		{
			var filingIndicator = new FilingIndicator(context, value, filed);
			base.Add(filingIndicator);
			return filingIndicator;
		}

		#region IEquatable implementation

		public bool Equals(IList<FilingIndicator> other)
		{
			return this.ContentCompare(other);
		}

		#endregion
	}
}