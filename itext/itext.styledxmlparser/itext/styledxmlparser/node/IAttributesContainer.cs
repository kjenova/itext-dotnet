/*
This file is part of the iText (R) project.
Copyright (c) 1998-2024 Apryse Group NV
Authors: Apryse Software.

This program is offered under a commercial and under the AGPL license.
For commercial licensing, contact us at https://itextpdf.com/sales.  For AGPL licensing, see below.

AGPL licensing:
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using System;

namespace iText.StyledXmlParser.Node {
    /// <summary>Interface for classes that can get and set attributes.</summary>
    public interface IAttributesContainer {
        /// <summary>Gets the attributes.</summary>
        /// <returns>the attributes</returns>
        IAttributes GetAttributes();

        /// <summary>Gets an attribute.</summary>
        /// <param name="key">the key of the attribute we want to get</param>
        /// <returns>the value of the attribute</returns>
        String GetAttribute(String key);
    }
}
