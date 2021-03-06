// *
// * Copyright (C) 2005 Mats Helander : http://www.puzzleframework.com
// *
// * This library is free software; you can redistribute it and/or modify it
// * under the terms of the GNU Lesser General Public License 2.1 or later, as
// * published by the Free Software Foundation. See the included license.txt
// * or http://www.gnu.org/copyleft/lesser.html for details.
// *
// *

using System;
using Puzzle.NPersist.Framework.Interfaces;
using Puzzle.NPersist.Framework.Mapping;

namespace Puzzle.NPersist.Framework.Persistence
{
	public interface IDataSourceManager : IContextChild, IDisposable
	{
		void Setup();

		IDataSource GetDataSource(ISourceMap sourceMap);

		IDataSource GetDataSource(object obj);

		IDataSource GetDataSource(Type type);

		IDataSource GetDataSource(object obj, string propertyName);
	}
}