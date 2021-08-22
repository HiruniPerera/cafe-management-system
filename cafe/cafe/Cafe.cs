using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe
{
	class Cafe
	{
public Cafe()
		{
			newlatte_coff = 0.0;
			newesspress_coffee = 0.0;
			newilatt_coff = 0.0;
			newvale_coff = 0.0;
			newacof_coff = 0.0;
			newamco_coff=0.0;
			newc_capp = 0.0;
			newicap_coff=0.0;

			newc_cake = 0.0;
			newr_velvet = 0.0;
			newb_forest = 0.0;
			newc_bos = 0.0;
			newc_lagos = 0.0;
			newc_kilb = 0.0;
			newc_cael = 0.0;
			newc_queen = 0.0;
		}

		//overload constructor
		public Cafe(double latte_coff, double esspress_coffee, double ilatt_coff, double vale_coff, double acof_coff, double amco_coff, double c_capp, double icap_coff,
			double c_cake, double r_velvet, double b_forest, double c_bos, double c_lagos, double c_kilb, double c_cael, double c_queen)
		{
			//coffee
			newlatte_coff = latte_coff;
			newesspress_coffee = esspress_coffee;
			newilatt_coff = ilatt_coff;
			newvale_coff = vale_coff;
			newacof_coff = acof_coff;
			newamco_coff = amco_coff;
			newc_capp = c_capp;
			newicap_coff = icap_coff;

			//cakes

			newc_cake = c_cake;
			newr_velvet = r_velvet;
			newb_forest = b_forest;
			newc_bos= c_bos;
			newc_lagos = c_lagos;
			newc_kilb = c_kilb;
			newc_cael = c_cael;
			newc_queen = c_queen;

		}
		//accessor function
		public double getlatte_coff()
		{
			return newlatte_coff;
		}

		public double getesspress_coff()
		{
			return newesspress_coffee;
		}

		public double getilat_coff()
		{
			return newilatt_coff;
		}

		public double getvale_coff()
		{
			return newvale_coff;
		}
		public double getacof_coff()
		{
			return newacof_coff;
		}

		public double getamco_coff()
		{
			return newamco_coff;
		}
		public double getc_capp()
		{
			return newc_capp;
		}
		public double geticap_coff()
		{
			return newicap_coff;
		}

		public double getc_cake()
		{
			return newc_cake;
		}

		public double getr_velvet()
		{
			return newr_velvet;
		}

		public double getb_forest()
		{
			return newb_forest;
		}
		public double getc_bos()
		{
			return newc_bos;
		}

		public double getc_lagos()
		{
			return newc_lagos;
		}

		public double getc_kilb()
		{
			return newc_kilb;
		}

		public double getc_cael()
		{
			return newc_cael;
		}
		public double getc_queen()
		{
			return newc_queen;
		}

		//member variables declared for coffee

		private double newlatte_coff;
		private double newesspress_coffee;
		private double newilatt_coff;
		private double newvale_coff;
		private double newacof_coff;
		private double newamco_coff;
		private double newc_capp;
		private double newicap_coff;


		private double newc_cake;
		private double newr_velvet;
		private double newb_forest;
		private double newc_bos;
		private double newc_lagos;
		private double newc_kilb;
		private double newc_cael;
		private double newc_queen;
	}
}
