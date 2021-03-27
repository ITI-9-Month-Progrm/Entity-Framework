using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SingleDB.Entity.FRONTEND_RESERVATIONDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDB.EntityConfiguration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
			builder.HasKey(R => R.Id);
			builder.Property(R => R.first_name).HasMaxLength(50).IsRequired();
			builder.Property(R => R.last_name).HasMaxLength(50).IsRequired();
			builder.Property(R => R.birth_day).HasMaxLength(50).IsRequired();
			builder.Property(R => R.gender).HasMaxLength(50).IsRequired();
			builder.Property(R => R.phone_number).HasMaxLength(50).IsRequired();
			builder.Property(R => R.email_address).IsRequired();
			builder.Property(R => R.number_guest).IsRequired();

			builder.Property(R => R.street_address).IsRequired();
			builder.Property(R => R.apt_suite).HasMaxLength(50).IsRequired();
			builder.Property(R => R.city).IsRequired();
			builder.Property(R => R.state).HasMaxLength(50).IsRequired();
			builder.Property(R => R.zip_code).HasMaxLength(10).IsRequired();
			builder.Property(R => R.room_type).HasMaxLength(10).IsRequired();
			builder.Property(R => R.room_floor).HasMaxLength(10).IsRequired();
			builder.Property(R => R.room_number).HasMaxLength(10).IsRequired();
			builder.Property(R => R.total_bill).IsRequired();
			builder.Property(R => R.payment_type).HasMaxLength(10).IsRequired();
			builder.Property(R => R.card_type).HasMaxLength(10).IsRequired();
			builder.Property(R => R.card_number).HasMaxLength(50).IsRequired();
			builder.Property(R => R.card_exp).HasMaxLength(50).IsRequired();
			builder.Property(R => R.card_cvc).HasMaxLength(10).IsRequired();
			builder.Property(R => R.arrival_time).IsRequired();
			builder.Property(R => R.leaving_time).IsRequired();
			builder.Property(R => R.check_in).IsRequired();
			builder.Property(R => R.break_fast).IsRequired();
			builder.Property(R => R.lunch).IsRequired();
			builder.Property(R => R.dinner).IsRequired();
			builder.Property(R => R.cleaning).IsRequired();
			builder.Property(R => R.towel).IsRequired();
			builder.Property(R => R.s_surprise).IsRequired();
			builder.Property(R => R.supply_status).IsRequired();
			builder.Property(R => R.food_bill).IsRequired();
		}

       
    }
}
