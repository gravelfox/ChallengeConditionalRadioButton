﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                notesImage.ImageUrl = "./pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                notesImage.ImageUrl = "./pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                notesImage.ImageUrl = "./phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                notesImage.ImageUrl = "./tablet.png";
            }
            else if (noneRadioButton.Checked)
            {
                notesImage.ImageUrl = "./brain.jpg";
            }
            else
            {
                notesImage.AlternateText = "Please Select a note-taking aparatus!";
            }
        }
    }
}