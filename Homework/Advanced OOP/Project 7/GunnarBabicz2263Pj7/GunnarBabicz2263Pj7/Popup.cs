using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Gunnar Babicz - 02/27/2023
* Class contains predefined error messages to
* make code more neat when needed.
* MessageBox learned from Note 4.9.
* Copied from Project 4 and tweaked for Project 5
*/


class Popup
{
    /* Gunnar Babicz - 02/13/2023
     * Creates an info popup based on method input.
     * Adapted from note 4.9
     */
    public static void Info(string title, string message)
    {
        MessageBox.Show(message, title,
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    /* Gunnar Babicz - 02/13/2023
     * Creates an error message based on method input.
     */
    public static void Error(string message)
    {
        MessageBox.Show(message, "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

