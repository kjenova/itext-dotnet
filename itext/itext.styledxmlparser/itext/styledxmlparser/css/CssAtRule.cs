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

namespace iText.StyledXmlParser.Css {
    /// <summary>Abstract superclass for all CSS at-rules (rules in CSS that start with an @ sign).</summary>
    public abstract class CssAtRule : CssStatement {
//\cond DO_NOT_DOCUMENT
        /// <summary>The rule name.</summary>
        internal String ruleName;
//\endcond

//\cond DO_NOT_DOCUMENT
        /// <summary>
        /// Creates a new
        /// <see cref="CssAtRule"/>
        /// instance.
        /// </summary>
        /// <param name="ruleName">the rule name</param>
        internal CssAtRule(String ruleName) {
            this.ruleName = ruleName;
        }
//\endcond

        /// <summary>Gets the rule name.</summary>
        /// <returns>the rule name</returns>
        public virtual String GetRuleName() {
            return ruleName;
        }
    }
}
