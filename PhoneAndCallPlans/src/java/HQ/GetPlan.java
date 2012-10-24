/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package HQ;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.ejb.Stateless;

/**
 *
 * @author ericccl21
 */
@WebService(serviceName = "GetPlan")
@Stateless()
public class GetPlan {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "getPlanList")
    public List getPlanList() throws SQLException, ClassNotFoundException {
               
            Class.forName("com.mysql.jdbc.Driver");
        
        
        Connection con = DriverManager.getConnection("jdbc:mysql://fastws.qut.edu.au:3306/n7706545", "n7706545", "aptx4869");
        Statement stmt = con.createStatement();
        ResultSet rset = stmt.executeQuery("SELECT * FROM Plans");
        List list = new ArrayList();
        while (rset.next()) {
            PlanList pList = new PlanList(
                    rset.getInt(1),
                    rset.getInt(2),
                    rset.getString(3),
                    rset.getDouble(4));
                list.add(pList);
            }
        return list;
    }
}
