
import Layout from '../components/Layout'
import ProductItem from '../components/productItem'
import Data from './api/product.api'


export default function Home() {
  return (
    <Layout>
      <div className="grid grid-cols-1 gap-4 md:grid-cols-3 lg:grid-cols-4">
        {Data.products.map((product)=>(
          <ProductItem product={product} key={product.id}></ProductItem> 
        ))}
      </div>
    </Layout>
  )
}
