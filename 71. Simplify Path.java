class Solution {
    public String simplifyPath(String path) {
        List<String> list = new ArrayList<String>();
        while(path.indexOf("//") >-1 ){
            path = path.replaceAll( "//","/" ) ;
        }
        path = path.substring(path.indexOf("/"),path.length());
        String[] nodes = path.split("/");
        for(String s: nodes){
            System.out.print(s);
            if(!s.equals(".") && !s.equals("")){
                if(s.equals("..")){
                    if(list.size() != 0){
                    list.remove(list.size() -1);
                    }
                }else{
                    list.add(s);
                }
            }
        }
        
        return "/" + String.join("/",list);
    }
}