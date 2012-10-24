/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package HQ;

/**
 *
 * @author ericccl21
 */

public class PlanList {
    private Integer planID, phoneModelID;
    private String phoneName;
    private Double costPerMonth;
    
    public PlanList() {
    }

    public PlanList(Integer planID, Integer phoneModelID, String phoneName, Double costPerMonth) {
        this.planID = planID;
        this.phoneModelID = phoneModelID;
        this.phoneName = phoneName;
        this.costPerMonth = costPerMonth;
    }
    
    /**
     * return a String list for prepare statement
     *
     * @return
     */
    public String[] toStringList() {
        String[] stringList = new String[4];
        stringList[0] = planID.toString();
        stringList[1] = phoneModelID.toString();
        stringList[2] = phoneName;
        stringList[3] = costPerMonth.toString();
        return stringList;
    }

    public Integer getPlanID() {
        return planID;
    }

    public void setPlanID(Integer planID) {
        this.planID = planID;
    }

    public Integer getPhoneModelID() {
        return phoneModelID;
    }

    public void setPhoneModelID(Integer phoneModelID) {
        this.phoneModelID = phoneModelID;
    }

    public String getPhoneName() {
        return phoneName;
    }

    public void setPhoneName(String phoneName) {
        this.phoneName = phoneName;
    }
            
    public Double getCostPerMonth() {
        return costPerMonth;
    }

    public void setCostPerMonth(Double costPerMonth) {
        this.costPerMonth = costPerMonth;
    }
            
                
}
