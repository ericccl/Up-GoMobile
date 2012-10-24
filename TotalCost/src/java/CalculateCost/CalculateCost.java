/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package CalculateCost;

import javax.ejb.Stateless;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

/**
 *
 * @author ericccl21
 */
@WebService(serviceName = "CalculateCost")
@Stateless()
public class CalculateCost {
    final Integer contractLength = 12;

    /**
     * Web service operation
     */
    @WebMethod(operationName = "getTotalCost")
    public double getTotalCost(@WebParam(name = "monthlyCost") double monthlyCost) {
        //TODO write your implementation code here:
        double total = monthlyCost * contractLength;
        return total;
    }
}
