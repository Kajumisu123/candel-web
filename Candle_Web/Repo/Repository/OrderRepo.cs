﻿using Microsoft.EntityFrameworkCore;
using Model.Models;
using Repo.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repository
{
    public class OrderRepo : IOrderRepo
    {
        private readonly candleContext _context;

        public OrderRepo(candleContext context)
        {
            _context = context;
        }
        public async Task<Order> Create(Order data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> Delete(OrderItem data)
        {
            _context.Remove(data);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Order>> GetALL()
        {
            var data = await _context.Orders.ToListAsync();
            return data;
        }

        public async Task<OrderItem> GetOrderItemById(int id)
        {
            var data = await _context.OrderItems.SingleOrDefaultAsync(x => x.OrderId.Equals(id));
            return data;
        }
        public async Task<Order> GetByOrderId(int id)
        {
            var data = await _context.Orders.SingleOrDefaultAsync(x => x.OrderId.Equals(id));
            return data;
        }
        public async Task<Order> GetByName(string? name)
        {
            var data = await _context.Orders.SingleOrDefaultAsync(x => x.User.Username.Equals(name));
            return data;
        }

        public async Task<Order> Update(Order data)
        {
            _context.Update(data);
            await _context.SaveChangesAsync();
            return data;
        }
    }
}
