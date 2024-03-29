/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;

using bingo.DAL;
using bingo.DO;
/// <summary>
/// Summary description for cmsCategoryBL
/// </summary>
namespace bingo.BL 
{
    public class cmsCategoryBL 
    {
    	#region Private Variables
		cmsCategoryDAL objcmsCategoryDAL;
		#endregion
		
        #region Public Constructors
        public cmsCategoryBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsCategoryDAL=new cmsCategoryDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsCategoryDO objcmsCategoryDO)
        {
            return objcmsCategoryDAL.Insert(objcmsCategoryDO);
        }

        public int Update(cmsCategoryDO objcmsCategoryDO)
        {
             return objcmsCategoryDAL.Update(objcmsCategoryDO);

        }

        public int Delete(cmsCategoryDO objcmsCategoryDO)
        {
             return objcmsCategoryDAL.Delete(objcmsCategoryDO);

        }

         public int DeleteAll()
        {
             return objcmsCategoryDAL.DeleteAll();
        }

        public cmsCategoryDO Select(cmsCategoryDO objcmsCategoryDO)
        {
            return objcmsCategoryDAL.Select(objcmsCategoryDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsCategoryDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsCategoryDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectByParent(int parent)
        {
            return objcmsCategoryDAL.SelectByParent(parent);
        }

        public DataTable SelectNewClass()
        {
            return objcmsCategoryDAL.SelectNewClass();
        }

        public DataTable SelectOne(cmsCategoryDO objCat)
        {
            return objcmsCategoryDAL.SelectOne(objCat);
        }



        public DataTable SelectMenuFoot()
        {
            return objcmsCategoryDAL.SelectMenuFoot();
        }

        public DataTable SelectClassTaiLieu()
        {
            return objcmsCategoryDAL.ClassTaiLieu();
        }
    }

}
