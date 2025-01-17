/*this caller file is codegen by juggle for c++*/
#ifndef _client_call_gate_caller_h
#define _client_call_gate_caller_h
#include <sstream>
#include <tuple>
#include <string>
#include <Icaller.h>
#include <Ichannel.h>
#include <boost/any.hpp>
#include <boost/make_shared.hpp>

namespace caller
{
class client_call_gate : public juggle::Icaller {
public:
    client_call_gate(boost::shared_ptr<juggle::Ichannel> _ch) : Icaller(_ch) {
        module_name = "client_call_gate";
    }

    ~client_call_gate(){
    }

    void connect_server(std::string argv0){
        auto v = boost::make_shared<std::vector<boost::any> >();
        v->push_back("client_call_gate");
        v->push_back("connect_server");
        v->push_back(boost::make_shared<std::vector<boost::any> >());
        (boost::any_cast<boost::shared_ptr<std::vector<boost::any> > >((*v)[2]))->push_back(argv0);
        ch->push(v);
    }

    void cancle_server(){
        auto v = boost::make_shared<std::vector<boost::any> >();
        v->push_back("client_call_gate");
        v->push_back("cancle_server");
        v->push_back(boost::make_shared<std::vector<boost::any> >());
        ch->push(v);
    }

    void forward_client_call_logic(std::string argv0,std::string argv1,std::string argv2){
        auto v = boost::make_shared<std::vector<boost::any> >();
        v->push_back("client_call_gate");
        v->push_back("forward_client_call_logic");
        v->push_back(boost::make_shared<std::vector<boost::any> >());
        (boost::any_cast<boost::shared_ptr<std::vector<boost::any> > >((*v)[2]))->push_back(argv0);
        (boost::any_cast<boost::shared_ptr<std::vector<boost::any> > >((*v)[2]))->push_back(argv1);
        (boost::any_cast<boost::shared_ptr<std::vector<boost::any> > >((*v)[2]))->push_back(argv2);
        ch->push(v);
    }

    void heartbeats(){
        auto v = boost::make_shared<std::vector<boost::any> >();
        v->push_back("client_call_gate");
        v->push_back("heartbeats");
        v->push_back(boost::make_shared<std::vector<boost::any> >());
        ch->push(v);
    }

};

}

#endif
