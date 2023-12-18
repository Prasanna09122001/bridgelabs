const IS_AbBSENT=0;
const IS_PART_TIME=1;
const IS_FULL_TIME=2;
const PART_TIME_HR=4;
const Full_TIME_HR=8;
const WAGE_PER_HR=20;
const NUM_OF_WORKING_DAYS=20;
const MAX_HRS_IN_A_MONTH=160;

//UC6
function CalculateDailyWage(Hrs)
{
    return Hrs*WAGE_PER_HR;
}

var TotalEmphrs=0;
let totalWorkingDay = 0;
const DailyWageArray = new Array();
while (TotalEmphrs < MAX_HRS_IN_A_MONTH && totalWorkingDay < NUM_OF_WORKING_DAYS) {
    totalWorkingDay++;
    var empcheck1=Math.floor(Math.random()*10)%3;
    TotalEmphrs += getworkinghrs(empcheck1);
    console.log(empcheck1+" "+TotalEmphrs);
    DailyWageArray.push(CalculateDailyWage(TotalEmphrs));
}
let empWage1 = CalculateDailyWage(TotalEmphrs);
console.log("Total days :" + totalWorkingDay + " Total Hours : " + TotalEmphrs + " Emp Wages " + empWage1);
console.log(DailyWageArray)

function getworkinghrs()
{
    switch(empcheck1)
    {
    case IS_PART_TIME: 
        return PART_TIME_HR;
    case IS_FULL_TIME: 
        return Full_TIME_HR;
    case IS_AbBSENT:
         return IS_AbBSENT 
    }
}
