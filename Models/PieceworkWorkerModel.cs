// PieceworkWorkerModel.cs
// Author - Devanshu Dave
// Date Created- 28-11-2021
// Modified - 12/12/2021
// Description :- Piece workWorker Model which represents the data for piece work worker and Sneior worker 
//                which contains First name , last name messages, issenior and a method to calculate pay
//                with Entity framework


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab6IncIncPayRoll.Models
{
    public class PieceworkWorkerModel
    {
        /// <summary>
        /// An ID with an integer data type to be displayed and has some validations set up
        /// </summary>
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "The worker must have  a first name")]
        [Display(Name = "First Name")]
        /// <summary>
        /// Worker's First Name to be displayed and has some validation set up
        /// </summary>
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "The last Name must have last name")]
        [Display(Name = "Last Name")]
        /// <summary>
        /// Worker's Last Name to be displayed and has some validation set up
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Worker Messages to be displayed and has some appropriate validation set up
        /// </summary>
        [Required(ErrorMessage = "You must enter a Messages Sent")]
        [Range(typeof(int),"1", "15000", ErrorMessage = "Messages must be between 1 and 15000")]
        [Display(Name = "Messages Sent")]
        public int Messages { get; set; }

        /// <summary>
        /// IsSenior with bool data type to identity whether the user want to calculate for senior worker or not 
        /// </summary>
        [Required]
        [Display(Name = "Senior Worker ")]
        public bool IsSenior { get; set; } = true;

        /// <summary>
        /// Date time current
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Returns the workers calculated pay based on thier messages sent
        /// </summary>
        /// <returns>pay with calculated value</returns>
        public decimal GetPay()
        {

            // if pieceworkWeker then enter this if block
            if (IsSenior == false)
            {

                // declared pay variable to hold calculate value
                // declared with decimal data type and initialized with 0
                decimal pay = 0;
                

                const int WorkerMessagesSentFirst = 1;
                // declared static workerMessagesSentSecond variable as int and kept as 1249
                const int WorkerMessagesSentSecond = 1249;
                // declared static workerMessagesThirdBound variable as int and kept as 1250
                const int WorkerMessagesThirdBound = 1250;
                // declared static workerMessagesFourthBound variable as int and kept as 2499
                const int WorkerMessagesFourthBound = 2499;
                // declared static workerMessagesFifthBound variable as int and kept as 2500
                const int WorkerMessagesFifthBound = 2500;
                // declared static workerMessagesSixthBound variable as int and kept as 3749
                const int WorkerMessagesSixthBound = 3749;
                // declared static workerMessagesSeventhBound variable as int and kept as 3750
                const int WorkerMessagesSeventhBound = 3750;
                // declared static workerMessagesEighthBound variable as int and kept as 4999
                const int WorkerMessagesEighthBound = 4999;
                // declared static MaximumumMessagesSent variable as int and kept as 5000
                const int MaximumumMessagesSent = 5000;
                // declared static workerFirstPay variable as decimal and kept as 0.02M
                const decimal WorkerFirstPay = 0.025M;
                // declared static workerSecondPay variable as decimal and kept as 0.024M
                const decimal WorkerSecondPay = 0.03M;
                // declared static workerThirdPay variable as decimal and kept as 0.028M
                const decimal WorkerThirdPay = 0.035M;
                // declared static workerFourthPay variable as decimal and kept as 0.034M
                const decimal WorkerFourthPay = 0.041M;
                // declared static workerFifthPay variable as decimal and kept as 0.04M
                const decimal WorkerFifthPay = 0.048M
 ;
                // range validation
                //  if and elseif statement to check for messages range and approprietly calculate the pay
                if (Messages >= WorkerMessagesSentFirst && Messages <= WorkerMessagesSentSecond)
                {
                    // formula
                    pay = Messages * WorkerFirstPay;
                }
                // if between 1250 and 2499 then calculate with 0.024 
                else if (Messages >= WorkerMessagesThirdBound && Messages <= WorkerMessagesFourthBound)
                {
                    // formula
                    pay = Messages * WorkerSecondPay;
                }
                // if between 2500 and 3749 then calculate with 0.028
                else if (Messages >= WorkerMessagesFifthBound && Messages <= WorkerMessagesSixthBound)
                {
                    // formula
                    pay = Messages * WorkerThirdPay;
                }
                // if between 3750 and 4999 then calculate with 0.034
                else if (Messages >= WorkerMessagesSeventhBound && Messages <= WorkerMessagesEighthBound)
                {
                    //formula
                    pay = Messages * WorkerFourthPay;
                }
                // if above 5000 then calculate with 0.04
                else if (Messages >= MaximumumMessagesSent)
                {
                    //formula
                    pay = Messages * WorkerFifthPay;
                }
                // return pay
                return pay;
            }
            // else enter this block
            else
            {
                // declared seniorPay variable to hold calculate value
                // declared with decimal data type and initialized with 0
                decimal seniorPay = 0;
                const int WorkerMessagesSentFirst = 1;
                // declared static workerMessagesSentSecond variable as int and kept as 1249
                const int WorkerMessagesSentSecond = 1249;
                // declared static workerMessagesThirdBound variable as int and kept as 1250
                const int WorkerMessagesThirdBound = 1250;
                // declared static workerMessagesFourthBound variable as int and kept as 2499
                const int WorkerMessagesFourthBound = 2499;
                // declared static workerMessagesFifthBound variable as int and kept as 2500
                const int WorkerMessagesFifthBound = 2500;
                // declared static workerMessagesSixthBound variable as int and kept as 3749
                const int WorkerMessagesSixthBound = 3749;
                // declared static workerMessagesSeventhBound variable as int and kept as 3750
                const int WorkerMessagesSeventhBound = 3750;
                // declared static workerMessagesEighthBound variable as int and kept as 4999
                const int WorkerMessagesEighthBound = 4999;
                // declared static MaximumumMessagesSent variable as int and kept as 5000
                const int MaximumumMessagesSent = 5000;
                // declared static workerFirstPay variable as decimal and kept as 0.018M
                const decimal WorkerFirstPay = 0.018M;
                // declared static workerSecondPay variable as decimal and kept as 0.021M
                const decimal WorkerSecondPay = 0.021M;
                // declared static workerThirdPay variable as decimal and kept as 0.024M
                const decimal WorkerThirdPay = 0.024M;
                // declared static workerFourthPay variable as decimal and kept as 0.027M
                const decimal WorkerFourthPay = 0.027M;
                // declared static workerFifthPay variable as decimal and kept as 0.03M
                const decimal WorkerFifthPay = 0.03M;
                // declared BasePay constant with decimal data type and assigned 270.00 
                const decimal BasePay = 270.00M;
                // range validation
                //  if and elseif statement to check for messages range and approprietly calculate the pay
                // if between 1 and 1249 then calculate with appropriate value
                if (Messages >= WorkerMessagesSentFirst && Messages <= WorkerMessagesSentSecond)
                {
                    // formula
                    seniorPay = (Messages * WorkerFirstPay) + BasePay;
                }
                // if between 1250 and 2499 then calculate with appropriate value  
                else if (Messages >= WorkerMessagesThirdBound && Messages <= WorkerMessagesFourthBound)
                {
                    // formula
                    seniorPay = (Messages * WorkerSecondPay) + BasePay;
                }
                // if between 2500 and 3749 then calculate with appropriate value  
                else if (Messages >= WorkerMessagesFifthBound && Messages <= WorkerMessagesSixthBound)
                {
                    // formula
                    seniorPay = (Messages * WorkerThirdPay) + BasePay;
                }
                // if between 3750 and 4999 then calculate with appropriate value
                else if (Messages >= WorkerMessagesSeventhBound && Messages <= WorkerMessagesEighthBound)
                {
                    //formula
                    seniorPay = (Messages * WorkerFourthPay) + BasePay;
                }
                // if above 5000 then calculate with appropriate value
                else if (Messages >= MaximumumMessagesSent)
                {
                    //formula
                    seniorPay = (Messages * WorkerFifthPay) + BasePay;
                }
                // return  calculated seniorPay
                return seniorPay;
            }
            
        }
      
    }
}
