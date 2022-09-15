import React from 'react'
import Link from 'next/Link';
import Image from 'next/Image'
import Data from '../pages/api/product.api';


export default function ProductItem(products) {
  return (
    <div className='card'>
            <Link href={`${products.title}`}> 
            <a>
                <Image 
                src = {products.image}
                alt = {products.title}
                className="rounded shadow"

                
                />

            </a>

            </Link>
            <div className="flex flex-col items-center justify-center p-5">
                <Link href={`/product/${products.title}`} >
                <a>
                    <h2 className='text-lg'>{products.title}</h2>
                </a>
                
                </Link>
                <p className='mb-2'>{products.category}</p>
                <p >${products.price}</p>
                <button className='primary-button' type='button'>
                    Add to cart
                </button>
            </div>

    </div>
  )
}
