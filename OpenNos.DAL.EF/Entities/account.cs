/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

namespace OpenNos.DAL.EF
{
    using Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Account
    {
        #region Instantiation

        public Account()
        {
            Character = new HashSet<Character>();
            GeneralLog = new HashSet<GeneralLog>();
            PenaltyLog = new HashSet<PenaltyLog>();
        }

        #endregion

        #region Properties

        public long AccountId { get; set; }

        public AuthorityType Authority { get; set; }

        public virtual ICollection<Character> Character { get; set; }

        public virtual ICollection<GeneralLog> GeneralLog { get; set; }

        public DateTime LastCompliment { get; set; }

        public int LastSession { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Password { get; set; }

        public virtual ICollection<PenaltyLog> PenaltyLog { get; set; }

        #endregion
    }
}